using AutoMapper;
using DAL.Concrete;
using DAL.Interfaces;
using System;
using System.Windows.Forms;
using TradingCompany.BLL.Concrete;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;
using Unity;

namespace TradingCompany.WF
{
    public static class Program
    {
        public static UnityContainer Container;
        public static UserDTO currentUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureUnity();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm lf = Container.Resolve<LoginForm>();

            if (lf.ShowDialog() == DialogResult.OK)
            {
                currentUser = lf.GetCurrentUser();
                Application.Run(Container.Resolve<PostList>());
            }
            else
                Application.Exit();
        }

        private static void ConfigureUnity()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddMaps(typeof(PostDAL).Assembly);
                });

            Container = new UnityContainer();
            Container.RegisterInstance<IMapper>(config.CreateMapper());
            Container.RegisterType<IPostDAL, PostDAL>()
                     .RegisterType<IUserDAL, UserDAL>()
                     .RegisterType<IProductDAL, ProductDAL>()
                     .RegisterType<ICategoryDAL, CategoryDAL>()
                     .RegisterType<IPostManager, PostManager>()
                     .RegisterType<IProductManager, ProductManager>()
                     .RegisterType<ICategoryManager, CategoryManager>()
                     .RegisterType<IAuthenticationManager, AuthenticationManager>();
        }
    }
}
