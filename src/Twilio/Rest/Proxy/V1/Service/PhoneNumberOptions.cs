/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Proxy.V1.Service 
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Add a Phone Number to the Service's Proxy Number Pool.
    /// </summary>
    public class CreatePhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Phone Number.
        /// </summary>
        public string Sid { get; set; }
        /// <summary>
        /// The phone_number
        /// </summary>
        public Types.PhoneNumber PhoneNumber { get; set; }

        /// <summary>
        /// Construct a new CreatePhoneNumberOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        public CreatePhoneNumberOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Sid != null)
            {
                p.Add(new KeyValuePair<string, string>("Sid", Sid.ToString()));
            }

            if (PhoneNumber != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumber", PhoneNumber.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Delete a specific Phone Number from the Service.
    /// </summary>
    public class DeletePhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Phone Number.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeletePhoneNumberOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Phone Number. </param>
        public DeletePhoneNumberOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Retrieve a list of all Phone Numbers in the Proxy Number Pool for this Service.
    /// </summary>
    public class ReadPhoneNumberOptions : ReadOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadPhoneNumberOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        public ReadPhoneNumberOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Fetch a specific Phone Number.
    /// </summary>
    public class FetchPhoneNumberOptions : IOptions<PhoneNumberResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Phone Number.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchPhoneNumberOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Phone Number. </param>
        public FetchPhoneNumberOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}