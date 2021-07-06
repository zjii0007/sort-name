# sort-name
NameSorter is a simple console in C# that sorts a list of names according to condition :
Given a set of names, order that set first by last name, then by any given names the person may have. A name must have at least 1 given name and may have up to 3 given names.

The project is build using Visual Studio 2019

## Example Usage

Given a file called unsorted-names-list.txt containing the following list of names;
```javascript
Janet Parsons
Vaughn Lewis
Adonis Julius Archer
Shelby Nathan Yoder
Marin Alvarez
London Lindsey
Beau Tristan Bentley
Leo Gardner
Hunter Uriah Mathew Clarke
Mikayla Lopez
Frankie Conner Ritter
```
Executing the program in the following way;
Will result the sorted names to screen;
```javascript
cd ./path-to-executable
name-sorter ./unsorted-names-list.txt
Marin Alvarez
Adonis Julius Archer
Beau Tristan Bentley
Hunter Uriah Mathew Clarke
Leo Gardner
Vaughn Lewis
London Lindsey
Mikayla Lopez
Janet Parsons
Frankie Conner Ritter
Shelby Nathan Yoder
```
and a file will be generated in the working directory called sorted-names-list.txt containing the sorted names.
 
