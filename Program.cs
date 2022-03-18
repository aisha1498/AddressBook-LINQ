using AddressBookLINQ;

Console.WriteLine("Welcome To AddressBook System using LINQ");
AddrssBookModel model = new AddrssBookModel();
AddressBookDataTable dataTable = new AddressBookDataTable();
dataTable.CreateTable(model);