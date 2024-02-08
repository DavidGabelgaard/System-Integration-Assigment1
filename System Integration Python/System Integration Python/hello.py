from flask import Flask
from System_Integration_Python import load_users_from_json, load_users_from_csv, load_users_from_txt, load_users_from_xml, load_users_from_yaml

app = Flask(__name__)

@app.route("/txt")
def get_users_as_string_from_txt():
    return load_users_from_txt('../../DataFiles/User.txt').__str__()

@app.route("/json")
def get_users_as_string_from_json():
    return load_users_from_json('../../DataFiles/User.json').__str__()

@app.route("/csv")
def get_users_as_string_from_csv():
    return load_users_from_csv('../../DataFiles/User.csv').__str__()

@app.route("/xml")
def get_users_as_string_from_xml():
    return load_users_from_xml('../../DataFiles/User.xml').__str__()

@app.route("/yaml")
def get_users_as_string_from_yaml():
    return load_users_from_yaml('../../DataFiles/User.Yaml').__str__()

