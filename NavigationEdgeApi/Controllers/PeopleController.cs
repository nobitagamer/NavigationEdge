﻿using NavigationEdgeApi.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.ValueProviders;

namespace NavigationEdgeApi.Controllers
{
    public class PeopleController : ApiController
    {
		public HttpResponseMessage Get([ModelBinder] int pageNumber)
		{
			return null;
		}
	}
}
