using BlazorApp.Models;

namespace BlazorApp.Pages.UserInfo
{
    public partial class Directory
    {
        public List<PersonModel> People { get; set; }

        public Directory()
        {
            People = new List<PersonModel>
        {
            new PersonModel
            {
                FirstName = "Tim",
                LastName = "Corey",
                Addresses = new List<AddressModel>
                {
                    new AddressModel
                    {
                        AddressType = "Home Address",
                        StreetAddress = "123 Oat St",
                        City = "Scranton",
                        State = "PA",
                        ZipCode = "18512"
                    },
                    new AddressModel
                    {
                        AddressType = "Vacation Home",
                        StreetAddress = "101 Beachfront Ave",
                        City = "Miami",
                        State = "FL",
                        ZipCode = "12543"
                    }
                }
            },

            new PersonModel
            {
                FirstName = "Sue",
                LastName = "Storm",
                Addresses = new List<AddressModel>
                {
                    new AddressModel
                    {
                        AddressType = "Home Address",
                        StreetAddress = "115 Justice Way",
                        City = "Los Angelos",
                        State = "CA",
                        ZipCode = "94356"
                    }
                }
            },

            new PersonModel
            {
                FirstName = "Bob",
                LastName = "Smith",
                Addresses = new List<AddressModel>()
            }
        };
        }
    }
}
