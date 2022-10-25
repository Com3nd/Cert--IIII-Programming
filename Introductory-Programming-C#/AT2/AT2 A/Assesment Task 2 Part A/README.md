Assessment Instrument: 
Assessment 2: C# Program with unit tests
Read the Car Dealer Showroom scenario described in the appendix.
You are required to write and test a C# program that satisfies all the requirements for this 
scenario. 
Please complete the following tasks. 
Part A: Documented Program
1. Write a C# WPF or Windows Forms program that meets the requirements. The program 
must include the following features:
a. The program must have a graphical user interface (GUI) frontend that displays 
the car inventory and provide the ability for the user to add, remove or search for 
cars.
b. The program must use an array to hold the car inventory details. Other data 
structures may be used as needed.
c. The program must include validation. (eg. To check that at least one vacant 
parking bay exists before a new car can be added.)
d. The program must demonstrate two examples of array search algorithms to look 
through the inventory of the array:
i. Sequential (eg. To find cars in a price range, or to find a vacant position.)
ii. Random Access (eg. The program must be able to directly access the 
inventory array by position to find which car is in a numbered parking bay.)
2. The program should adhere to the C# coding standards document provided.
3. Comment your program to explain the purpose of your code. Use single-line, multi-line 
and XML documentation comments.



Appendix 1
You are the manager of a car dealership with a showroom that can house up to 20 cars. Each car is 
assigned to a numbered parking bay. You need a program that allows you to manage your inventory 
of cars.
For each car, you must record details about it such as:
• Registration number
• Make
• Model
• Year
• Price
• File name of image/photo of car
When a car is sold to a customer, it needs to be removed from the inventory. Those car details need 
to be retained in a list of Sold Cars.
From time to time, new cars are also purchased from manufacturers and auctions for resale, if there 
is at least one vacant space available in the showroom where the car can be parked. The new car 
must be added to the “cars for sale” inventory. Use an array to represent the inventory so that an 
item’s position indicates its car parking bay number.
Besides being able to add and remove inventory items, dealership staff also need to be able to 
search the inventory. The following types of searches are typical:
• To find which car is allocated to a particular car parking bay. (ie. The user specifies a number between 
1 and 20). Rationale: The keys for the cars are stored on hooks corresponding to the car parking bay 
number. The result from this search will tell the user which hook the key is on.
• To find a specific car by registration number. Rationale: To ensure that car registrations are renewed 
before they expire, check airbag compliance, etc. 
• To find all cars within a specified price range. Rationale: Customers should only be shown cars that 
are priced within their budget.
