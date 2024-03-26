using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Commonn.Communication;
using Commonn.Domain;

namespace Server
{
    public class ClientHandler
    {
        private readonly Sender sender;
        private readonly Receiver receiver;
        private readonly Socket socket;
        public ClientHandler(Socket socket)
        {
            this.socket = socket;
            sender = new Sender(socket);
            receiver = new Receiver(socket);
        }

        public void Handle()
        {
            try
            {
                while (true)
                {
                    Request req = (Request)receiver.Receive();
                    Response res = HandleRequests(req);
                    sender.Send(res);
                }
            }
            catch (Exception)
            {
                Server.clients.Remove(this);
            }
            finally
            {
                socket.Close();
            }
        }

        private Response HandleRequests(Request req)
        {
            Response res = new Response();
            try
            {
                switch (req.Operation)
                {
                    #region log
                    case Operation.Login:
                        {
                            res.Result = Controller.Instance.Login((Korisnik)req.Argument);
                        }
                        break;
                    case Operation.Logout:
                        {
                            Controller.Instance.Logout((String)req.Argument);
                        }
                        break;
                    #endregion
                    #region muzicka grupa
                    case Operation.CreateMusicGroup:
                        {
                            Controller.Instance.AddMusicGroup((MuzickaGrupa)req.Argument);
                            res.Message = "Sistem je uspešno kreirao muzičku grupu!";
                        }
                        break;
                    case Operation.GetAllMusicGroups:
                        {
                            res.Result = Controller.Instance.GetAllMusicGroups();
                        }
                        break;
                    case Operation.GetMusicGroupByName:
                        {
                            res.Result = Controller.Instance.GetAllMusicGroupsFilter((string)req.Argument);
                        }
                        break;
                    case Operation.GetMusicGroupById:
                        {
                            res.Result = Controller.Instance.GetMusicGroupsById((MuzickaGrupa)req.Argument);
                        }
                        break;
                    case Operation.UpdateMusicGroup:
                        {
                            Controller.Instance.UpdateMusicGroup((MuzickaGrupa)req.Argument);
                            res.Message = "Sistem je uspešno izmenio muzičku grupu!";
                        }
                        break;
                    #endregion
                    #region izvodjac
                    case Operation.CreateSinger:
                        {
                            Controller.Instance.AddSinger((List<Izvodjac>)req.Argument);
                            res.Message = "Sistem je uspešno kreirao izvođača!";
                        }
                        break;
                    case Operation.GetAllSingers:
                        {
                            res.Result = Controller.Instance.GetAllSingers();
                        }
                        break;

                    case Operation.GetSingerByName:
                        {
                            res.Result = Controller.Instance.GetSingerByName((string)req.Argument);
                        }
                        break;
                    case Operation.GetSingerById:
                        {
                            res.Result = (Izvodjac)Controller.Instance.GetSingerById((int)req.Argument);
                        }
                        break;
                    case Operation.UpdateSinger:
                        {
                            Controller.Instance.UpdateSinger((Izvodjac)req.Argument);
                            res.Message = "Sistem je uspešno izmenio izvođača!";
                        }
                        break;
                    case Operation.DeleteSinger:
                        {
                            Controller.Instance.DeleteSinger((Izvodjac)req.Argument);
                            res.Message = "Sistem je uspešno izbrisao izvođača!";
                        }
                        break;
                    #endregion
                    #region koncert
                    case Operation.GetAllConcerts:
                        {
                            res.Result = Controller.Instance.GetAllConcerts();
                        }
                        break;
                    #endregion
                    #region nastup
                    case Operation.CreateScene:
                        {
                            Controller.Instance.AddScene((List<Nastup>)req.Argument);
                            res.Message = "Sistem je uspešno kreirao nastup!";
                        }
                        break;
                    case Operation.GetAllScenes:
                        {
                            res.Result = Controller.Instance.GetAllScenes();
                        }
                        break;
                    case Operation.GetSceneById:
                        {
                            res.Result = (Nastup)Controller.Instance.GetSceneById((int)req.Argument);
                        }
                        break;
                    case Operation.GetSceneByDate:
                        {
                            res.Result = Controller.Instance.GetSceneByDate((string)req.Argument);
                        }
                        break;
                    case Operation.UpdateScene:
                        {
                            Controller.Instance.UpdateScene((Nastup)req.Argument);
                            res.Message = "Sistem je uspešno izmenio nastup!";
                        }
                        break;
                        #endregion
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }

            return res;
        }

        internal void Close()
        {
            socket?.Close();
        }
    }
}
