using AtividadeAvaliativaFinal.Context;
using AtividadeAvaliativaFinal.CRUD;
using AtividadeAvaliativaFinal.Untils;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

namespace AtividadeAvaliativaFinal.Model
{
    class ClientCRUD : CRUD<ClientModel>
    {
        public bool Create(ClientModel client)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Clients);
                var clients = JsonSerializer.Deserialize<List<ClientModel>>(json);

                clients.Add(client);

                string _json = JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = true});
                File.WriteAllText(DBJson.Clients, _json);

                ShowMessages.Success("Client created.");
                return true;
            }
            catch(Exception ex)
            {
                ShowMessages.Error(ex, "Create User", "Cannot create a user.");
                return false;
            }
        }

        public List<ClientModel> Read()
        {
            try
            {
                string json = File.ReadAllText(DBJson.Clients);
                var clients = JsonSerializer.Deserialize<List<ClientModel>>(json);

                if (clients != null) return clients;
                else return new List<ClientModel>(0);
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Get Users", "Cannot get users.");
                return new List<ClientModel>(0);
            }
        }

        public ClientModel ReadById(int id)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Clients);
                var clients = JsonSerializer.Deserialize<List<ClientModel>>(json);
                var client = clients.FirstOrDefault(c => c.Id == id);

                if(client != null) return client;
                else return new ClientModel();
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Get User", "Cannot get user.");
                return new ClientModel();
            }
        }


        public void Update(ClientModel client)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Clients);
                var clients = JsonSerializer.Deserialize<List<ClientModel>>(json);

                var _client = clients.FirstOrDefault(c => c.Id == client.Id);

                if (_client != null) 
                {
                    _client.Name = client.Name;
                    _client.Email = client.Email;
                    _client.Phone = client.Phone;
                    _client.CPF = client.CPF;
                }
                else ShowMessages.ErrorAlt($"The client #{client.Id} don't exist");

                string _json = JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(DBJson.Clients, _json);

                ShowMessages.Success("Client edited.");
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Edit User", "Cannot edit user.");
            }
        }

        public void Delete(ClientModel client)
        {
            try
            {
                string json = File.ReadAllText(DBJson.Clients);
                var clients = JsonSerializer.Deserialize<List<ClientModel>>(json);

                var _client = clients.FirstOrDefault(c => c.Id == client.Id);

                if (_client != null) clients.Remove(_client);
                else ShowMessages.ErrorAlt($"The client #{client.Id} don't exist");

                string _json = JsonSerializer.Serialize(clients, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(DBJson.Clients, _json);

                ShowMessages.Success("Client deleted.");
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Delete User", "Cannot delete user.");
            }
        }

        public int GenId()
        {
            try
            {
                string json = File.ReadAllText(DBJson.Clients);
                var clients = JsonSerializer.Deserialize<List<ClientModel>>(json);

                int newId;

                if (clients.Count >= 500)
                {
                    ShowMessages.ErrorAlt("You can't register more clients (limit: 500).");
                    return 0;
                }
                else
                {
                    Random random = new Random();

                    while (true)
                    {
                        newId = random.Next(1, 500);
                        var client = clients.FirstOrDefault(c => c.Id == newId);
                        if (client == null) break;
                    }

                    return newId;
                }
            }
            catch (Exception ex)
            {
                ShowMessages.Error(ex, "Generate Client Id", "Cannot generate id.");
                return 0;
            }
        }
    }
}
