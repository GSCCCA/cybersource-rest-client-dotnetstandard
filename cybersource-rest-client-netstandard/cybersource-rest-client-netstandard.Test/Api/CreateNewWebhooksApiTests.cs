/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing CreateNewWebhooksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CreateNewWebhooksApiTests
    {
        private CreateNewWebhooksApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CreateNewWebhooksApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreateNewWebhooksApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CreateNewWebhooksApi
            //Assert.IsInstanceOfType(typeof(CreateNewWebhooksApi), instance, "instance is a CreateNewWebhooksApi");
        }

        
        /// <summary>
        /// Test CreateWebhook
        /// </summary>
        [Test]
        public void CreateWebhookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateWebhook createWebhook = null;
            //var response = instance.CreateWebhook(createWebhook);
            //Assert.IsInstanceOf<InlineResponse2013> (response, "response is InlineResponse2013");
        }
        
        /// <summary>
        /// Test FindProductToSubscribe
        /// </summary>
        [Test]
        public void FindProductToSubscribeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string organizationId = null;
            //var response = instance.FindProductToSubscribe(organizationId);
            //Assert.IsInstanceOf<List<InlineResponse2003>> (response, "response is List<InlineResponse2003>");
        }
        
        /// <summary>
        /// Test SaveSymEgressKey
        /// </summary>
        [Test]
        public void SaveSymEgressKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string vCSenderOrganizationId = null;
            //string vCPermissions = null;
            //string vCCorrelationId = null;
            //SaveSymEgressKey saveSymEgressKey = null;
            //var response = instance.SaveSymEgressKey(vCSenderOrganizationId, vCPermissions, vCCorrelationId, saveSymEgressKey);
            //Assert.IsInstanceOf<InlineResponse2012> (response, "response is InlineResponse2012");
        }
        
    }

}
