# Day 2 Notes

## Topics Covered

* Constraints
* Primary Key
* Foreign Key
* Unique Constraint
* Default Constraint
* Identity Column
* CRUD Operations

---

## Constraints

### Primary Key

* Uniquely identifies each record.
* Cannot contain NULL values.
* No duplicate values allowed.

### Foreign Key

* Establishes relationships between tables.
* Maintains referential integrity.

### Unique Constraint

* Prevents duplicate values in a column.

### Default Constraint

* Assigns a default value when no value is provided.

### Identity Column

* Generates auto-increment values automatically.

### Not Null

* Ensures a column must contain a value.

---

## Relationships Implemented

* Users → Roles
* Employees → Departments
* Employees → Users
* Documents → Employees

---

## CRUD Operations

### Create

```sql
INSERT INTO TableName (...)
VALUES (...);
```

### Read

```sql
SELECT * FROM TableName;
```

### Update

```sql
UPDATE TableName
SET ColumnName = Value
WHERE Condition;
```

### Delete

```sql
DELETE FROM TableName
WHERE Condition;
```

---

## Additional Queries Practiced

```sql
WHERE
```

```sql
ORDER BY
```

```sql
INNER JOIN
```

---

## Activities Performed

* Added UNIQUE constraints
* Added FOREIGN KEY relationships
* Inserted sample data into tables
* Performed CRUD operations
* Executed SELECT queries with conditions
* Performed INNER JOIN between Employees and Departments

---

## Challenges Faced

* Duplicate data insertion due to repeated execution of INSERT statements.
* Constraint creation error when attempting to add an existing constraint.

---

## Outcome

Successfully implemented table relationships, inserted sample data, and performed CRUD operations using SQL Server.
