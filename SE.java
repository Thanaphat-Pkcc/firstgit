import java.util.*;
import java.io.*;
import java.awt.*;
import javax.swing.*;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
class SE 
{
	public static void main(String[] args) 
	{
		Scanner sc = new Scanner(System.in);
		//*********Manage Stock********//
		Stock st = new Stock();
		st.add(1000,"Coffee",50,10);
		st.add(1001,"Sugar",40,15);
		st.add(1002,"Milk",30,20);
		st.add(1003,"Egg",20,5);
		st.add(1004,"Cup",10,3);
		

		st.write();
		st.cutoff("Coffee",5);
		st.delete("Milk");
		st.delete(1001);

		st.setdata(1003,"KUY",300,20);
		st.setdata(1003,"Milk",30,20);
		st.setdata(1000,"Coffee",50,10);
		
		
		//*******Sale slip*******//
		Sale_slip ss = new Sale_slip();
		
		ss.setorder("001","slip1.txt","tea",2);
		ss.setorder("001","slip1.txt","cake",1);
		ss.setorder("001","slip1.txt","water",3);
		ss.calculatortotal("slip1.txt");
		ss.calculatortax("slip1.txt");
		ss.clear();
		ss.setorder("002","slip2.txt","water",1);
		ss.setorder("002","slip2.txt","cupcake",1);
		ss.setorder("002","slip2.txt","cake",3);
		ss.calculatortotal("slip2.txt");
		ss.calculatortax("slip2.txt");

		
	}
}
class Stock
{	
	private ArrayList<Integer> id = new ArrayList<Integer>();
	private ArrayList<String> name = new ArrayList<String>();
	private ArrayList<Integer> price = new ArrayList<Integer>();
	private ArrayList<Integer> qty = new ArrayList<Integer>();
	private int index;


	public String getname(int i){
		return name.get(i);
	}

	public int getprice(int i){
		return price.get(i);
	}

	public int getqty(int i){
		return qty.get(i);
	}

	public void setdata(int id ,String newname  ,int newprice, int newqty){
		index = this.id.indexOf(id);
				//Change data
		name.remove(index);
		name.add(index,newname);
		price.remove(index);
		price.add(index,newprice);
		qty.remove(index);
		qty.add(index,newqty);
		
		write();
	}

	public void add(int id,String name,int price,int qty){

		this.id.add(id);
		this.name.add(name);
		this.price.add(price);
		this.qty.add(qty);
	}

    public void delete(String name){
		index = this.name.indexOf(name);
		id.remove(index);
		this.name.remove(index);
		price.remove(index);
		qty.remove(index);
		write();
	}

	  public void delete(int id){
		index = this.id.indexOf(id);
		this.id.remove(index);
		name.remove(index);
		price.remove(index);
		qty.remove(index);
		write();
	}

	public void read(){
		try{
		FileInputStream read = new FileInputStream("Stock.txt");
		DataInputStream input = new DataInputStream(read);
		BufferedReader bf = new BufferedReader(new InputStreamReader(input));
		String line;
		
		while ((line = bf.readLine())!=null)
		{
			System.out.println(line);			
		}
		input.close();
			}

		catch(IOException e){
			System.out.println("ERROR");
		}

	}

	public void cutoff(String name , int qty){
		index = this.name.indexOf(name);
		qty = this.qty.get(index) - qty;
		this.qty.add(index,qty);
		write();	
		
	}

	public void write(){
		try
		{
			FileWriter writer = new FileWriter("Stock.txt");
			BufferedWriter out = new BufferedWriter(writer);
			out.write("ID");
			out.write("\t");
			out.write("Name");
			out.write("\t");
			out.write("Price");
			out.write("\t");
			out.write("Qty");
			out.newLine();
			for (int i=0;i<id.size();i++)
			{
				String Sid = Integer.toString(id.get(i));
				out.write(Sid);
				out.write("\t");
				out.write(name.get(i));
				out.write("\t");
				String Sprice = Integer.toString(price.get(i));
				out.write(Sprice);
				out.write("\t");
				String Sqty = Integer.toString(qty.get(i));
				out.write(Sqty);
				out.write("\t");
				out.newLine();
			}

			out.close();
		}
		catch (IOException e)
		{
			System.out.println("ERROR");
		}
	}
}

class Sale_slip {
	private ArrayList<String> name = new ArrayList<String>();
	private ArrayList<Integer> price = new ArrayList<Integer>();
	private ArrayList<Integer> qty = new ArrayList<Integer>();
	private String id_sale;
	private String date;
	private double total;
	private double tax;
	private Date assignDate = new Date();
	
	public void calculatortax(String text){
		tax = 0;
		tax = total*0.07;
		write(text);
	}
	
	public void calculatortotal(String text){
		total = 0;
		for (int i=0;i<price.size();i++ )
		{
			total =total + (price.get(i)*qty.get(i));
		}

		write(text);
	}

	public void clear(){
		name.clear();
		price.clear();
		qty.clear();
	}
	public void setorder(String id,String text,String name,int qty){
		id_sale = id;
			if (name=="coffee")
			{
				this.name.add(name);
				price.add(50);
				this.qty.add(qty);
			}
			else if (name == "cake")
			{
				this.name.add(name);
				price.add(30);
				this.qty.add(qty);
			}
			else if (name == "water")
			{
				this.name.add(name);
				price.add(10);
				this.qty.add(qty);
			}
			else if (name == "cupcake")
			{
				this.name.add(name);
				price.add(40);
				this.qty.add(qty);
			}
			else if (name == "tea")
			{
				this.name.add(name);
				price.add(35);
				this.qty.add(qty);
			}
			else{
				System.out.println("Can not find");
			}
			write(text);
		
	}

	public void write(String text){
			String path = text;
			File file = new File(path);
			
			try
			{
			
			FileWriter writer = new FileWriter(path);
			BufferedWriter out = new BufferedWriter(writer);
			out.write("ID\t");out.write(id_sale);
			out.newLine();
			out.write("Date,");out.write(assignDate.toString());
			out.newLine();
			out.write("Name");
			out.write("\t");
			out.write("Qty");
			out.write("\t");
			out.write("Price");
			out.newLine();

				for (int i=0;i<name.size();i++ )
				{
				out.write(name.get(i));
				out.write("\t");
				String Sqty = Integer.toString(qty.get(i));
				out.write(Sqty);
				out.write("\t");
				String Sprice = Integer.toString(price.get(i));
				out.write(Sprice);
				out.newLine();
				}
			out.write("Tax");
			out.write("\t");
			out.write("\t");
			String Stax= Double.toString(tax);
			out.write(Stax);
			out.newLine();
			out.write("Total");
			out.write("\t");
			out.write("\t");
			String Stotal = Double.toString(total);
			out.write(Stotal);

			out.close();
			}
			catch (IOException e)
			{
				System.out.println("ERROR");
			}
	}
}