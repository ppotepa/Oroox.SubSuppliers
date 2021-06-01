﻿using System.Collections.Generic;

namespace Oroox.SubSuppliers.Response
{
    public class ResponseBase
    {
        public ResponseBase() { }
        public IEnumerable<string> ValidationMessages { get; set; }
        public string Response { get; set; }
        public object Result { get; set; }
        public string TraceId { get; set; }
        public string RedirectUrl 
        {
            get 
            {
               return _redirectUrl ?? string.Empty;
            }
            set => _redirectUrl = value;
        }
        private string _redirectUrl;
    }
}
