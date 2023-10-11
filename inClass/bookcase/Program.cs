// See https://aka.ms/new-console-template for more information

Book narnia = new Book("C.S. Lewis","The Lion, The Witch, and The Wardrobe");
Bookcase b = new Bookcase();
narnia.Display();
b.AddBook(narnia);
b.DisplayBookcase();