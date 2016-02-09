﻿using System;
using System.Collections.Generic;

namespace Twilio
{
	public class Request
	{
		private System.Net.Http.HttpMethod method;
		private Uri uri;
		private string username;
		private string password;
        private List<KeyValuePair<string, string>> queryParams;
        private List<KeyValuePair<string, string>> postParams;

		public Request (System.Net.Http.HttpMethod method, Uri uri, string username, string password)
		{
			this.method = method;
			this.uri = uri;
			this.username = username;
			this.password = password;
		}

		public Uri constructURL() {
			return uri;
        }

		public System.Net.Http.HttpMethod getMethod() {
            return this.method;
        }
        
        private static System.Net.Http.HttpContent encodeParameters(List<KeyValuePair<string, string>> data) {
            return new System.Net.Http.FormUrlEncodedContent(data);
        }
        
        public System.Net.Http.HttpContent encodePostParams() {
            return encodeParameters(this.postParams);
        }
	}
}
