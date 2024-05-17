using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyContactApp.Data;
using MyContactApp.Models;

namespace MyContactApp.Services
{
    public class ContactService(ContactContext context)
    {
        private readonly ContactContext _context = context;

        public void AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public List<Contact> GetContacts()
        {
            return _context.Contacts.ToList();
        }
    }
}