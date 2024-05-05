import psycopg
from configparser import ConfigParser
import json

CONFIG_PATH = "Erreur 404"

try:
    with open('C:\programmation\Radium-Launcher\Radium-Launcher\server\database\path.txt', 'r') as f:
        file_contents = f.read()
        CONFIG_PATH = file_contents
except FileNotFoundError:
    print(f"Fichier path.txt introuvable")

def config(filename=CONFIG_PATH, section='postgresql'):
    parser = ConfigParser()

    parser.read(filename)

    db = {}
    if section in parser:
        for key in parser[section]:
            db[key] = parser[section][key]
    else:
        raise Exception(f"La section {section} n\'a pas ete trouve dans le fichier {filename}.")

    return db

def connect_to_database():
    try:
        db_config = config()

        conn = psycopg.connect(**db_config)
    
        cursor = conn.cursor()

        cursor.execute('SELECT version()')
        db_version = cursor.fetchone()

        cur = conn.cursor()

        cur.execute('SELECT * FROM account;')

        rows = cur.fetchall()

        for row in rows:
            print(row)

        cursor.close()
        conn.close()
        
        return db_version

    except (Exception, psycopg.Error) as error:
        print(f'Erreur dans la connection a PostgreSQl: {error}')

db_connect = connect_to_database()

print(f'Version de la base de donnee: {db_connect}')

