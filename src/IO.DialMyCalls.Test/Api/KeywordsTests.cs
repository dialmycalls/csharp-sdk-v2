/* 
 * DialMyCalls API
 *
 * The DialMyCalls API
 *
 * OpenAPI spec version: 2.0.1
 * Contact: support@dialmycalls.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.DialMyCalls.Client;
using IO.DialMyCalls.Api;

namespace IO.DialMyCalls.Test
{
    /// <summary>
    ///  Class for testing Keywords
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class KeywordsTests
    {
        private Keywords instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Keywords();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Keywords
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Keywords
            //Assert.IsInstanceOfType(typeof(Keywords), instance, "instance is a Keywords");
        }

        
        /// <summary>
        /// Test DeleteKeywordByID
        /// </summary>
        [Test]
        public void DeleteKeywordByIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keywordId = null;
            //var response = instance.DeleteKeywordByID(keywordId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetKeywordByID
        /// </summary>
        [Test]
        public void GetKeywordByIDTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string keywordId = null;
            //var response = instance.GetKeywordByID(keywordId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetKeywords
        /// </summary>
        [Test]
        public void GetKeywordsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string range = null;
            //var response = instance.GetKeywords(range);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}
