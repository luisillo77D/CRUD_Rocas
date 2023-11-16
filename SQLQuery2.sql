BULK INSERT Muestras1
FROM 'datos.csv'
WITH (
  FIELDTERMINATOR = ',',
  ROWTERMINATOR = '\n'
);