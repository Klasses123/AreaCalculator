SELECT p.Name AS ProductName
      , c.Name AS CategoryName
  FROM ProductCategory AS pc
  RIGHT JOIN Products AS p ON pc.ProductId = p.Id
  LEFT JOIN Categories AS c ON pc.CategoryId = c.Id