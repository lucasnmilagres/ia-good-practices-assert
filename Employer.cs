public class Employee
{
	 //These are the class properties
	 public string Name { get; set; }
	 public string Age { get; set; }
	 private string Phone { get; set; }
	 public double Salary { get; set; }
	 public string Address_Street { get; set; }
	 public string AddressCity { get; set; }
	 public string AddressZip { get; set; }
	 public string AddrNumber { get; set; }
	 public Company Company { get; set; }

	 //This is the class constructor
	 public Employee(string name, string x, string y, int salary, string street, string city, string zip, string number, Company company)
	 {
		 Name = name;
		 Age = x;
		 Phone = y;
		 Salary = salary;
		 Address_Street = street;
		 //AddrNumber = street.Split('-')[1];
		 AddrNumber = number;
		 AddressCity = city;
		 AddressZip = zip;
		 Company = company;
	 }
	 
	 public int moveAddress(string newCity, string newStreet, string newZip, string newNumber)
	 {
		 if (String.IsEmpty(newCity) || String.IsEmpty(newStreet) || String.IsEmpty(newZip) || String.IsEmpty(newNumber))
			 return -1;

		 Address_Street = newStreet;
		 AddrNumber = newNumber;
		 AddressZip = newZip;
		 return 0;
	 }
 }
