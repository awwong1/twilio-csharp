﻿using System;
using System.Threading.Tasks;

namespace Twilio
{
	public class SystemNetClient : HttpClient
	{
		public SystemNetClient () {
		}

		public async override Task<Response> makeRequest(Request request) {
			Uri url = request.constructURL();
			var httpClient = new System.Net.Http.HttpClient();
            var httpRequest = new System.Net.Http.HttpRequestMessage();
            httpRequest.Method = request.getMethod();
            httpRequest.RequestUri = request.constructURL();
            httpRequest.Properties.Add("Accept", "application/json");
			httpRequest.Properties.Add("Accept-Encoding", "utf-8");
			httpRequest.Content = request.encodePostParams();
            var response = await httpClient.SendAsync(httpRequest);
			var content = response.Content;
			var statusCode = response.StatusCode;

			return new Response(statusCode, content);
		}
	}
}
