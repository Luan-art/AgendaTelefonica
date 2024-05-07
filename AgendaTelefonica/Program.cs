using AgendaTelefonica;

ContactList contactList = new ContactList();

PhonesList phonesList1 = new PhonesList();
Phone phone1 = new Phone("222222222");
Phone phone2 = new Phone("999999999");
phonesList1.Add(phone1);
phonesList1.Add(phone2);

Address address1 = new Address("12345-678", "Example City", "EX", "Example Street", "Avenue", 123, "Apt. 456");

Contact contact = new Contact("Luan", "luan@gmail", address1, phonesList1);

contactList.Add(contact);

PhonesList phonesList2 = new PhonesList();
Phone phone1_1 = new Phone("111111111");
Phone phone1_2 = new Phone("555555555");
phonesList2.Add(phone1_1);
phonesList2.Add(phone1_2);

Address address2 = new Address("54321-876", "Another City", "AC", "Another Street", "Boulevard", 456, "Apt. 789");

Contact contact1 = new Contact("Maria", "maria@example.com", address2, phonesList2);

contactList.Add(contact1);

PhonesList phonesList3 = new PhonesList();
Phone phone2_1 = new Phone("333333333");
Phone phone2_2 = new Phone("777777777");
phonesList3.Add(phone2_1);
phonesList3.Add(phone2_2);

Address address3 = new Address("98765-432", "Yet Another City", "YA", "Yet Another Street", "Road", 789, "");

Contact contact2 = new Contact("Pedro", "pedro@example.com", address3, phonesList3);

contactList.Add(contact2);

contactList.ShowByName("Pedro");

PhonesList phonesListEdit = new PhonesList();
Phone phoneEdit = new Phone("1111111");
Phone phoneEdit2 = new Phone("999999");
phonesListEdit.Add(phoneEdit);
phonesListEdit.Add(phoneEdit2);


Address addressEdit = new Address("98765-432", "Edit City", "YA", "Yet Another Street", "Road", 789, "");


Contact contactEdit = new Contact("PedroEdit", "pedro@example.Edit", addressEdit, phonesListEdit);


contactList.EditByName("Pedro", contactEdit);

contactList.ShowByName("PedroEdit");
