﻿using System.Collections.Generic;
using static BlazorUtils.Interfaces.Invokers.JsInvoke;

namespace BlazorUtils.Cookie
{
    /// <summary>
    /// Providing all methods for managing cookies
    /// </summary>
    public static class Cookies
    {
        private static Dictionary<string, Interfaces.Cookie.Cookie> _dict;

        private static Dictionary<string, Interfaces.Cookie.Cookie> Dict
        {
            get
            {
                if (_dict == null)
                {
                    _dict = new Dictionary<string, Interfaces.Cookie.Cookie>();
                    var strCookies = Invoke<string>("LMTCookies");
                    foreach (var ele in strCookies.Split(';'))
                    {
                        var keyValue = ele.Split('=');
                        _dict.Add(keyValue[0].Trim(), new Interfaces.Cookie.Cookie(keyValue[0].Trim(), keyValue[1].Trim(), -2));
                    }
                }

                return _dict;
            }
        }

        /// <summary>
        /// Get cookie by key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Interfaces.Cookie.Cookie Get(string key) => Dict[key];

        /// <summary>
        /// Set a new cookie. If day expires is 0, it will be a session cookie. Set it to minus value in order to remove.
        /// </summary>
        /// <param name="cookie">Object representing cookie</param>
        public static void Set(Interfaces.Cookie.Cookie cookie)
        {
            Invoke<object>("LMTCookiesAdd", cookie.Key, cookie.Value, cookie.Expires, cookie.Path);
            //Set null to force getter to reinitialize list of cookies
            _dict = null;
        }

        /// <summary>
        /// Clear all cookies
        /// </summary>
        public static void Clear()
        {
            foreach(var ele in Dict)
            {
                Remove(ele.Key);
            }
        }

        /// <summary>
        /// Remove a specific cookie
        /// </summary>
        /// <param name="key"></param>
        public static void Remove(string key)
        {
            Invoke<object>("LMTCookiesAdd", key, "", -999, "/");
        }
    }
}

