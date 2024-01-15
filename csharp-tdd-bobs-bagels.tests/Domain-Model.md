Domain Model

1.
As a member of the public,
So I can order a bagel before work,
I'd like to add a specific type of bagel to my basket.
=> addBagel()

2.
As a member of the public,
So I can change my order,
I'd like to remove a bagel from my basket.
=> removeBagel()

3.
As a member of the public,
So that I can not overfill my small bagel basket
I'd like to know when my basket is full when I try adding an item beyond my basket capacity.
=> addBagel() =>Message
4.
As a Bob's Bagels manager,
So that I can expand my business,
I’d like to change the capacity of baskets.
=> Private int _capacity
=> Public int Capacity{get set}

5.
As a member of the public
So that I can maintain my sanity
I'd like to know if I try to remove an item that doesn't exist in my basket.
=> removeBagel()=> string Message

Class Basket()
User story | Method						 |	Scenario											| Output
-----------|-----------------------------|------------------------------------------------------|-------------------------------
Nr 1       | addBagel(string)			 | if Basket.Length < capacity => Basket.append(bagel)	|
Nr 3 	   | addBagel(string)			 | if Basket.Length >= capacity							| string Message "Basket is full"
Nr 2	   | removeBagel(string)		 | Basket.remove(Basket.IndexOf(bagel))					|	
Nr 5	   | removeBagel(string)		 | if Basket.IndexOf(string) < 0						| string Message "Nothing was removed, Bagel was not in the basket"		 							
Nr 4	   | Public int Capacity{get set}| set _capacity = int value							|

//variables
Public string[] Basket = new string[5];
Private int capacity = 5;//any chosen number