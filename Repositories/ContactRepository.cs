using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using MVC1_portfolio.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVC1_portfolio.Repositories
{
    public class ContactRepository
    {
        private readonly IAmazonDynamoDB _dynamoDb;
        private const string TableName = "PortfolioContacts";

 
        public ContactRepository(IAmazonDynamoDB dynamoDb)
        {
            _dynamoDb = dynamoDb;
        }

        public async Task SaveAsync(ContactRecord contact)
        {
            var item = new Dictionary<string, AttributeValue>
            {
                ["ContactId"] = new AttributeValue { S = contact.ContactId },
                ["FName"] = new AttributeValue { S = contact.FName },
                ["LName"] = new AttributeValue { S = contact.LName },
                ["Email"] = new AttributeValue { S = contact.Email },
                ["Message"] = new AttributeValue { S = contact.Message },
                ["CreatedAt"] = new AttributeValue { S = contact.CreatedAt }
            };

            var request = new PutItemRequest
            {
                TableName = TableName,
                Item = item
            };

            await _dynamoDb.PutItemAsync(request);
        }
    }
}
