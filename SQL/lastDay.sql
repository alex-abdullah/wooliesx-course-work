CREATE DATABASE betelgeuse;
USE betelgeuse;

SHOW TABLES;

CREATE TABLE users (
	id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    `name` VARCHAR(255) NOT NULL,
    age INT UNSIGNED NOT NULL,
    date_created TIMESTAMP DEFAULT NOW(),
    PRIMARY KEY (id)
);

ALTER TABLE users
ADD age INT UNSIGNED NOT NULL;

INSERT INTO users (`name`)
VALUES ('John');

SELECT * FROM users;

INSERT INTO users (`name`)
VALUES ('Calum'), ('Remi'), ('Martyna');

INSERT INTO users (`name`, age)
VALUES ('Sandra', 25);

SELECT * FROM users;

-- CHALLENGE 5 
-- All fields should not allow NULL values

-- Create a table to store trainers with the following fields:
CREATE TABLE pokemon_trainers (
	id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    
    -- A name field that contains the trainer's name      
    `name` VARCHAR(255) NOT NULL,
    
    -- An age field that contains the trainer's age
    age INT UNSIGNED NOT NULL,
    
    -- A birth field that contains the city where the trainer was born
    birth_place VARCHAR(255) NOT NULL,
    
    -- A creation date that defaults to the current timestamp
    date_created TIMESTAMP DEFAULT NOW(),
    
    
    
    -- Should have an id field that is also marked as a primary key
    PRIMARY KEY (id)
);

INSERT INTO users (`name`)
VALUES ('Calum'), ('Remi'), ('Martyna');

INSERT INTO pokemon_trainers (`name`, age, birth_place)
VALUES ('Ash Ketchum', 10, 'Palletown'), ('Misty', 10, 'Cerulean City'), ('Brock', 15, 'Pewter City');

SHOW TABLES;
SELECT * FROM pokemon_trainers;

DELETE FROM pokemon_trainers
WHERE id = (4);

DELETE FROM pokemon_trainers
WHERE id = (5);

DELETE FROM pokemon_trainers
WHERE id = (6);


-- CHALLENGE 6
-- Create a table called pokemons with the following fields:
CREATE TABLE pokemon (
	-- id should be a primary key
	id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    
    -- name: name of the pokemon
    `name` VARCHAR(255) NOT NULL,
    
    -- damage: damage dealt by it's ability
    damage INT UNSIGNED NOT NULL,
    
    -- trainer_id: the id of the trainer that owns the pokemon
    trainer_id INT UNSIGNED NOT NULL,
    
    date_created TIMESTAMP DEFAULT NOW(),
    PRIMARY KEY (id),
    FOREIGN KEY (trainer_id) REFERENCES pokemon_trainers(id)
);

INSERT INTO pokemon (`name`, damage, trainer_id)
VALUES ('Pikachu', 50, 1), ('Charizard', 100, 1), ('Bulbasaur', 20, 1);

INSERT INTO pokemon (`name`, damage, trainer_id)
VALUES ('Snorlax', 10, 2), ('Eevee', 15, 2), ('Magikarp', 1, 2);

INSERT INTO pokemon (`name`, damage, trainer_id)
VALUES ('Squirtle', 40, 3), ('Mewtwo', 100, 3), ('Onix', 70, 3);

SELECT * FROM pokemon;
SELECT * FROM pokemon_trainers;

DROP TABLE pokemon;

CREATE TABLE pokemon (
	-- id should be a primary key
	id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    
    -- name: name of the pokemon
    `name` VARCHAR(255) NOT NULL,
    
    -- damage: damage dealt by it's ability
    damage INT UNSIGNED NOT NULL,
    
    -- trainer_id: the id of the trainer that owns the pokemon
    trainer_id INT UNSIGNED NOT NULL,
    
    date_created TIMESTAMP DEFAULT NOW(),
    PRIMARY KEY (id),
    FOREIGN KEY (trainer_id) REFERENCES pokemon_trainers(id)
);

INSERT INTO pokemon (`name`, damage, trainer_id)
VALUES ('Pikachu', 50, 1), ('Charizard', 100, 1), ('Bulbasaur', 20, 1);

INSERT INTO pokemon (`name`, damage, trainer_id)
VALUES ('Snorlax', 10, 2), ('Eevee', 15, 2), ('Magikarp', 1, 2);

INSERT INTO pokemon (`name`, damage, trainer_id)
VALUES ('Squirtle', 40, 3), ('Mewtwo', 100, 3), ('Onix', 70, 3);

SELECT * FROM pokemon;
SELECT * FROM pokemon_trainers;




-- Insert 2 trainers into your trainers table
-- Insert 3 pokemon for each trainer in the pokemons table




SELECT * FROM pokemon_trainers;

CREATE TABLE cars (
	id INT UNSIGNED NOT NULL AUTO_INCREMENT,
    make VARCHAR(255) NOT NULL,
    model VARCHAR(255) NOT NULL,
    user_id INT UNSIGNED NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (user_id) REFERENCES users(id)
    );
    
    
    
    

INSERT INTO cars (make, model, user_id)
VALUES
	('Honda', 'Civic', 2);
    
SELECT * FROM cars;

INSERT INTO cars (make, model, user_id)
VALUES
	('Toyota', 'Corolla', 1);
    SELECT * FROM cars;
    





