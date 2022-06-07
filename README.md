# Classes and objects
# Task
Implement classes with inheritances: the Human base class, from which the Student and Employee classes are inherited, and the Driver class is inherited from Employee.
```
         +-------+
     +---+ HUMAN +-----+
     |   +-------+     |
     v                 v
+----+----+     +------+-----+
| STUDENT |     |  EMPLOYEE  |
+---------+     +------+-----+
                       |
                       v
                   +---+----+
                   | DRIVER |
                   +--------+
```
Classes contain fields:
- **Human**: _surname_, _name_, _patronymic_, _birthday_.
- **Student**: _faculty_, _course_, _group_.
- **Employee**: _organization_, _salary_, _stage_.
- **Driver**: _mark of the car_, _model of the car_.

**Prohibit the ability to create a Human class, only heirs.**  
**Prohibit inheritance from the Driver class.**

For classes, implement a constructor without parameters, a constructor with parameters, a copy constructor, a destructor. When calling constructors/destructors, the corresponding informational messages should be output to the console.

In the body of the class, define methods that will allow the user:
1. Edit the contents of each of the fields.
2. Display class data in an easy-to-read format.
3. The ability to get the number of full years.

The functionality of the program should allow:
1. Add information about a new person.
2. Edit the fields of an existing record about a person.
3. Delete information about a person.
4. Display information about a person in a convenient readable form.
5. Display information about all people in a convenient readable form.
