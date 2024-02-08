from typing import List
from dataclasses import dataclass, field
import xml.etree.ElementTree as ET


class UserModel(object):
    def __init__(self, FirstName, LastName, Valid, Address, Age, Education):
       self.FirstName = FirstName
       self.LastName = LastName
       self.Valid = Valid
       self.Address = Address
       self.Age = Age
       self.Education = Education
    def __str__(self) -> str:
        return f"UserModel: FirstName={self.FirstName}, LastName={self.LastName}, Valid={self.Valid}, Address={self.Address}, Age={self.Age}, Education={self.Education}"


class UserListModel(object):
    def __init__(self, Users):
        self.Users = Users
    def __str__(self) -> str:
        user_strings = [str(user) for user in self.Users]
        return '\n'.join(user_strings)