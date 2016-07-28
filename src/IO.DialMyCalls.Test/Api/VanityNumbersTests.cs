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
using IO.DialMyCalls.Model;

namespace IO.DialMyCalls.Test
{
    /// <summary>
    ///  Class for testing VanityNumbers
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VanityNumbersTests
    {
        private VanityNumbers instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VanityNumbers();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VanityNumbers
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' VanityNumbers
            //Assert.IsInstanceOfType(typeof(VanityNumbers), instance, "instance is a VanityNumbers");
        }

        
        /// <summary>
        /// Test DeleteVanityNumberById
        /// </summary>
        [Test]
        public void DeleteVanityNumberByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vanityNumberId = null;
            //var response = instance.DeleteVanityNumberById(vanityNumberId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetVanityNumberById
        /// </summary>
        [Test]
        public void GetVanityNumberByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vanityNumberId = null;
            //var response = instance.GetVanityNumberById(vanityNumberId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetVanityNumbers
        /// </summary>
        [Test]
        public void GetVanityNumbersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string range = null;
            //var response = instance.GetVanityNumbers(range);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test UpdateVanityNumberById
        /// </summary>
        [Test]
        public void UpdateVanityNumberByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateVanityNumberByIdParameters updateVanityNumberByIdParameters = null;
            //string vanityNumberId = null;
            //var response = instance.UpdateVanityNumberById(updateVanityNumberByIdParameters, vanityNumberId);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
    }

}