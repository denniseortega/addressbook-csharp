using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBookApp.Models;
using System;

namespace AddressBookApp.Models
{
  public class Contact
  {
    private string _name;
    private int _number;
    private string _address;
    private int _id;
    private static List<Contact> _contacts = new List<Contact>{};

    public Contact(string name, int number, string address)
    {
      _name = name;
      _number = number;
      _address = address;
      _contacts.Add(this);
      _id = _contacts.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }
    public int GetNumber()
    {
      return _number;
    }
    public void SetNumber(int newNumber)
    {
      _number = newNumber;
    }
    public string GetAddres()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _contacts;
    }
    public static void ClearAll()
    {
      _contacts.Clear();
    }
    public static Contact Find (int searchId)
    {
      return _contacts[searchId-1];
    }
  }
}
