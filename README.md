# csharp_SinthujaKopalakirushnan
Gilded Rose Refactoring-Kata Solution – Sinthuja Kopalakirushnan


The Gilded rose is a complex problem to solve.
I used C# programming language for refactoring the Gilded rose.

Techniques used:
•	Used polymorphism
 
Used polymorphism to separate the items and reduce the complexity. 
Created class for each of the item types.

•	As per the requirement to not to alter the item class or item property, so I used the base class (Item class) as an abstract class and created derived class for the sub-categories of the items.

•	Used factory pattern

Used the factory pattern, where the factory object (Item) is used to create the other objects. In this case, the new keyword does not need to be used frequently. The Item is the parent class and it perform different tasks. 

Created an ItmFactory class to switch between different item categories.

