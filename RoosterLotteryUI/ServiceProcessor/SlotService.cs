using System.Numerics;
using System.Text;
using System.Text.Json;
using RoosterLottery.Models;
using RoosterLotteryUI.Properties;
using RestSharp;
using RestSharp.Serializers.Json;

namespace Client.Services
{
    internal class SlotService
    {
        private readonly RestClient _restClientSlot;

        internal SlotService()
        {
            _restClientSlot = new RestClient($"{Resources.ApiUrl}/api/Slot/");
        }

        internal async Task<List<Slot?>> Load()
        {
            var request = new RestRequest($"{nameof(Load)}", Method.Get);

            RestResponse<List<Slot>> response = await _restClientSlot.ExecuteAsync<List<Slot>>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else
            {
                // Handle other types of unsuccessful responses
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return null;
        }

        internal async Task<Slot?> GetById(int id)
        {
            var request = new RestRequest($"{nameof(GetById)}/{id}", Method.Get);

            RestResponse<Slot> response = await _restClientSlot.ExecuteAsync<Slot>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                // Handle the not found response
                MessageBox.Show("No player found with the given ID.");
            }
            else
            {
                // Handle other types of unsuccessful responses
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return null;
        }

        internal async Task<Slot> SearchPlayerByPhoneNumber(string phoneNumber)
        {
            var request = new RestRequest($"{nameof(SearchPlayerByPhoneNumber)}", Method.Get);
            request.AddQueryParameter($"{nameof(phoneNumber)}", phoneNumber);

            RestResponse<Slot> response = await _restClientSlot.ExecuteAsync<Slot>(request);

            if (response.IsSuccessful)
            {
                return response.Data;
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                // Handle the not found response
                MessageBox.Show("No player found with the given phone number.");
            }
            else
            {
                // Handle other types of unsuccessful responses
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return null;
        }

        internal async Task<bool> Save(Slot player)
        {
            var request = new RestRequest($"{nameof(Save)}", Method.Post);
            request.AddJsonBody(player); // Serializes player object to JSON

            RestResponse response = await _restClientSlot.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return false;
        }

        internal async Task<bool> Delete(int id)
        {
            var request = new RestRequest($"{nameof(Delete)}/{id}", Method.Delete);

            RestResponse response = await _restClientSlot.ExecuteAsync(request);

            if (response.IsSuccessful)
            {
                return true;
            }
            else
            {
                MessageBox.Show($"An error occurred: {response.ErrorMessage}");
            }

            return false;
        }
    }
}
