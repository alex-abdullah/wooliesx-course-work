USE world_x;
SHOW TABLES;

SELECT * FROM cities;


SELECT c.`name` AS city, c.`population` FROM cities AS c;

-- filtering data

-- WHERE

SELECT * FROM cities AS c WHERE c.countries_code = "AUS";
SELECT * FROM cities AS c WHERE c.population > 1000000;

SELECT * FROM cities AS c
WHERE c.countries_code = "POL";

-- LIKE 

SELECT * FROM cities AS c
WHERE c.`name` LIKE 'new %';

-- multiple conditions

SELECT * FROM cities as c
WHERE c.`name` LIKE 'a%' OR c.population > 1000000;

SELECT * FROM cities AS c
WHERE c.`name` LIKE 'b%' AND c.population > 500000;

SELECT * FROM cities AS c
WHERE c.population BETWEEN 1000000 AND 2000000;

SELECT * FROM cities AS c
WHERE c.countries_code IN ('AUS', 'POL', 'AFG');

-- CHALLENGE
SELECT c.`countries_code`, c.`name`, c.`population` FROM cities AS c
WHERE c.population > 126304;

SELECT  c.`name`, c.`population` FROM cities AS c
WHERE c.`name` LIKE '%o%o%';

SELECT * FROM cities AS c
WHERE c.countries_code = "AFG" OR c.countries_code = "COD";

SELECT * FROM cities AS c
WHERE c.id % 23 = 0;

SELECT c.`name`, c.population FROM cities as c
WHERE c.`name` LIKE 'a%' OR c.countries_code LIKE 'a%';

SELECT c.id, c.`name`, c.population FROM cities as c
WHERE c.population > 1042340 OR c.`name` LIKE 'san%';

-- ordering data

-- LIMIT

SELECT * FROM cities 
lIMIT 50;

SELECT * FROM cities

-- first number is how many to skip, second number is how many results to display 
LIMIT 20, 100;

SELECT * FROM cities AS c
WHERE c.population  > 1000000
LIMIT 1, 10;

-- ORDER BY 

SELECT * FROM  cities as c
ORDER BY c.population;

SELECT * FROM cities AS c
ORDER BY c.countries_code, c.population DESC;

SELECT c.`name`, c.population FROM cities AS c
WHERE c.`name` LIKE 'san%'
ORDER BY c.population desc
LIMIT 2;

-- CHALLENGE 2

-- Get the name and country code for 20 cities that have a population greater than 123123, order your results by country_code from A-Z
SELECT c.`name`, c.population, c.countries_code FROM cities AS c
WHERE c.population > 123123
ORDER BY c.countries_code
LIMIT 20;

-- Get the name and country code for 13 cities that have a population less than 1231231, order your results by country_code from Z-A
SELECT c.`name`, c.population, c.countries_code FROM cities AS c
WHERE c.population < 1231231
ORDER BY c.countries_code DESC
LIMIT 13;

-- Get all fields for 10 cities in USA ordered by name A-Z and also descending population
SELECT * FROM cities AS c
WHERE c.countries_code = 'USA'
ORDER BY c.`name`, c.population DESC
LIMIT 10;

-- Get all fields for the 3 most populated cities in Saudi Arabia
SELECT * FROM cities AS c
WHERE c.countries_code = 'SAU'
ORDER BY c.population DESC
LIMIT 3;


-- Get all fields for the 6 least populated cities in Saudi Arabia
SELECT * FROM cities AS c
WHERE c.countries_code = 'SAU'
ORDER BY c.population ASC
LIMIT 6;

-- Get the names of the 5 most populated cities in Saudi Arabia, Brunei and Russia
SELECT c.`name`, c.countries_code, c.population FROM cities as c
WHERE c.countries_code = 'SAU'
ORDER BY c.population DESC
LIMIT 5;

SELECT c.`name`, c.countries_code, c.population FROM cities as c
WHERE c.countries_code = 'BRN'
ORDER BY c.population DESC;


SELECT c.`name`, c.countries_code, c.population FROM cities as c
WHERE c.countries_code = 'RUS'
ORDER BY c.population DESC
LIMIT 5;

-- Get the names of the 3 least populated cities in Russian excluding the least populated city
SELECT c.`name`, c.countries_code, c.population FROM cities as c
WHERE c.countries_code = 'RUS'
ORDER BY c.population
LIMIT 1, 3;

-- SQL DAY 2


-- Will return all columns for both tables 
SELECT * FROM cities c
INNER JOIN country_languages cl
ON c.countries_code = cl.countries_code;

-- Return specific columns 
SELECT c.`name`, c.population, cl.`language`, cl.countries_code FROM cities c
JOIN country_languages cl
ON c.countries_code = cl.countries_code;

SELECT c.`name`, c.district, ct.`code` FROM cities c
JOIN countries ct
ON c.countries_code = ct.`code`
WHERE ct.`name` = 'France'
ORDER BY c.district;

-- CHALLENGE 3 

-- Get the names for 100 most populated cities together with the countries they're located in and their respective population.
SELECT c.`name`, c.population, ct.`name` FROM cities c
JOIN countries ct
ON c.countries_code = ct.`code`
ORDER BY c.population DESC
LIMIT 100;

-- Get only the official languages spoken in each country.
SELECT ct.`name`, cl.`language`, cl.is_official FROM countries ct
JOIN country_languages cl
ON ct.`code` = cl.countries_code
WHERE cl.is_official = 'T';


-- Get all the records for all three tables without repeating columns multiple times.
SELECT c.id, c.`name`, c.countries_code, c.district, c.population, ct.capital, cl.language, cl.is_official, cl.percentage FROM cities c
JOIN countries ct
JOIN country_languages cl  
ON c.countries_code = ct.`code` AND c.countries_code = cl.countries_code;

SELECT * FROM cities c
JOIN countries ct ON ct.`code` = c.countries_code
UNION
SELECT * FROM cities c
JOIN country_languages cl ON c.countries_code = cl.countries_code;


-- Get all the countries that people speak French in.
-- Get all the cities where English is spoken with a population over 300000.
-- Get the names of the cities, countries and languages spoken for every country code that has 'U' as the middle letter.
-- Get the names of the countries with Arabic as the official language.
-- Get the population, city and country names where Chinese is spoken by less than 10% of the people.

SELECT c.`name`, c.population, ct.`name` FROM cities c
JOIN countries ct
ON c.countries_code = ct.`code`
JOIN country_languages cl
ON c.countries_code = cl.countries_code
WHERE cl.`language` = 'chinese' AND cl.percentage < 10;

-- AGGREGATIONS

-- COUNT

SELECT COUNT(*) FROM cities c
WHERE c.countries_code = 'NZL';

SELECT COUNT(DISTINCT c.countries_code) FROM cities c;

-- MAX && MIN

SELECT MAX(c.population) FROM cities c;
SELECT MIN(c.population) FROM cities c;

SELECT MAX(c.population) FROM cities c
WHERE c.countries_code = 'AUS';

-- AVG && SUM
SELECT AVG(c.population) FROM cities c;

SELECT AVG(c.population) FROM cities c
WHERE c.countries_code = 'POL';

SELECT SUM(c.population) FROM cities c
WHERE c.countries_code = 'USA';

-- GROUP BY
SELECT c.countries_code, SUM(c.population) FROM cities c
GROUP BY c.countries_code;

SELECT c.countries_code, ROUND(AVG(c.population)) AS average FROM cities c
WHERE c.countries_code IN ('AUS', 'POL', 'SAU', 'USA')
GROUP BY c.countries_code
ORDER BY average;



-- SQL CHALLENGE 4
-- Find the total population in Afghanistan.
SELECT SUM(c.population) FROM cities c
WHERE c.countries_code = 'AFG';

-- Find the average population of cities in Saudi Arabia.
SELECT AVG(c.population) FROM cities c
WHERE c.countries_code = 'SAU';

-- Find the 10 smallest country populations.
SELECT c.countries_code, SUM(c.population) AS SUM FROM cities c
GROUP BY c.countries_code
ORDER BY SUM
LIMIT 10;


-- Find the top 10 most populated countries that end with stan
SELECT ct.`name`, c.countries_code, SUM(c.population) AS SUM FROM cities c
JOIN countries ct ON c.countries_code = ct.`code`
WHERE ct.`name` LIKE '%stan'
GROUP BY c.countries_code
ORDER BY SUM DESC
LIMIT 10;

-- Find the least populated city for the top 10 most populated countries.
SELECT c.countries_code, c.`name`, SUM(c.population) AS total, MIN(c.population) AS least
FROM cities c
GROUP BY c.countries_code
ORDER BY total DESC
LIMIT 10;

-- Find the most populated city in countries that end with stan
SELECT MAX(c.population) AS max, c.`name`, ct.`name` FROM cities c
JOIN countries ct ON ct.`code` = c.countries_code
WHERE ct.`name` LIKE  '%stan'
GROUP BY c.countries_code;

-- Find the average population if cities that have a country code that contains a T


SELECT ROUND(AVG(population)), c.`name`, ct.`code` FROM cities c
JOIN countries ct on ct.`code` = c.countries_code
WHERE c.countries_code LIKE '%t%'
GROUP BY ct.`code`;

-- Find the most populated and least populated cities for each country that ends with stan, should be ordered alphabetically.
SELECT ct.`name` city, c.`name` country, ct.population
FROM cities ct
INNER JOIN countries c
ON c.`code` = ct.countries_code
WHERE (((ct.countries_code, ct.population) IN (
		SELECT ct.countries_code, MIN(ct.population)
        FROM cities ct
        GROUP BY ct.countries_code)) OR 
        ((ct.countries_code, ct.population) IN (
		SELECT ct.countries_code, MAX(ct.population)
        FROM cities ct
        GROUP BY ct.countries_code)))
        AND (c.`name` LIKE '%stan')
ORDER BY country ASC;

-- RELATIONSHIPS

-- ONE TO MANY
-- MANY TO MANY
-- ONE TO ONE 

TABLE COHORT 		

-- _ single character
-- % anything (one character, sentence, etc)