using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Pingfu.RemoveServerHeaderModule
{
    public class RemoveServerHeader : IHttpModule
    {
        /// <summary>
        /// 
        /// </summary>
        private List<string> headers = new List<string>();

        /// <summary>
        /// entry-point
        /// </summary>
        /// <param name="context"></param>
        public void Init(HttpApplication context)
        {
            headers.Add("Server");
            headers.Add("X-Powered-By");
            headers.Add("X-AspNet-Version");
			headers.Add("X-AspNetMvc-Version");

            context.PreSendRequestHeaders += OnPreSendRequestHeaders;
        }

        /// <summary>
        /// event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnPreSendRequestHeaders(object sender, EventArgs e)
        {
            foreach (var header in headers)
            {
                try
                {
                    // set the header value to string.Empty
                    HttpContext.Current.Response.Headers[header] = string.Empty;

                    // try to remove the header from the response
                    HttpContext.Current.Response.Headers.Remove(header);
                }
                catch (Exception)
                {
                    // no specific action, continue trying to remove headers
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            // nothing to dispose
        }
    }
}
