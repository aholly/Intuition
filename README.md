


Question 1

**It is important that this executes quickly as it will be used often. **

The Command and Query Responsibility Segregation (CQRS) pattern states that separate  operations for reading the data and seperate operations for writing or updating the data. This means that functions for reading and writing data are not kept in the same interface or class. The main advantages of doing this include:
	Each can be made to scale according to their own needs.
	Read operations can have a different architecture to support caching and performance, conversions to data transformation objects as required by clients
	Write operations can include data validation. The cqrs patterns can be used with mediatr and Azure bus for more performance.

#Question 2


The  chain of repsonsibiity pattern can be used here instead of if else statements

#Question 3


The Strategy Design Pattern can be used to refactor this code.

Tax Calculation will be created the using Strategy Pattern.
 
So, below classes will be involved,
	Strategy - ITaxCalculator
	Concrete Strategy - LocalTaxCalculator
	Context - Bill - Moved from CartTotal
Advantages
We can add new algorithm for Tax Calculation in the feature easily and algorithm can be selected at run time.
The actual creation of a TaxCalculator will be delegated to Factory method.




