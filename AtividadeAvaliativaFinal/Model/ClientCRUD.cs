using AtividadeAvaliativaFinal.CRUD;
using AtividadeAvaliativaFinal.Untils;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeAvaliativaFinal.Model
{
    class ClientCRUD : CRUD<ClientModel>
    {
        public bool Create(ClientModel user)
        {
            try
            {

            }
            catch(Exception error)
            {
                ShowMessages.Error(error, "Create User", "Cannot create a user.");
            }
        }
        
    }
}
