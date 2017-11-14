using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneToOneAssociationRealation
{
    class Address
    {
        public string HouseNo { get; set; }
        public string RoadNo { get; set; }
        public string PostCode { get; set; }
        public string District { get; set; }

        public Address(string houseNo,string roadNo,string postCode,string district)
        {
            HouseNo = houseNo;
            RoadNo = roadNo;
            PostCode = postCode;
            District = district;
        }

        public string GetFullAddress()
        {
            string fullAddress = "house no: " + HouseNo + ",Road no: " + RoadNo +
                ",post code: " + PostCode + ",District: " + District;
            return fullAddress;
        }
    }
}
