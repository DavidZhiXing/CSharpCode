- 有一个分数字段，如何选出前10的数据？

```sql
SELECT * FROM table ORDER BY score DESC LIMIT 10;
```

- 左连接表
    
```sql
SELECT * FROM table1 LEFT JOIN table2 ON table1.id = table2.id;
```

- 右连接表

```sql
SELECT * FROM table1 RIGHT JOIN table2 ON table1.id = table2.id;
```