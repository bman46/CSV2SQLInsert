# CSV2SQLInsert
Outputs the contents of a CSV file so they are formatted to be pasted into a MySQL INSERT statement.

## Example:
CSV File (`trees.csv`):
```
Index,Girth,Height,Volume(ft^3)
1,8.3,70,10.3
2,8.6,65,10.3
```
Command: 
```
CSV2SQLInsert trees.csv
```
Console Output:
```
('Index','Girth','Height','Volume(ft^3)'),
('1','8.3','70','10.3'),
('2','8.6','65','10.3');
```
MySQL Statement:
```
INSERT INTO trees (Index,Girth,Height,Volume) VALUES
('1','8.3','70','10.3'),
('2','8.6','65','10.3');
```
