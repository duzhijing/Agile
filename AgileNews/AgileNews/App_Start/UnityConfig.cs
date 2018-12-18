using System;

using Unity;

namespace AgileNews
{
    using AgileNewsCache;
    using AgileNewsCommon;
    using AgileNewsEntity;
    using AgileNewsService;
    using IAgileNewsService;


    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<INewsService, NewsService>();
            container.RegisterType<IAdminPersonService, AdminPersonService>();
            container.RegisterType<IAdminRoleService, AdminRoleService>();
            container.RegisterType<ICommentsService, CommentsService>();
            container.RegisterType<ICrawlerDetailsService, CrawlerDetailsService>();
            container.RegisterType<ICrawlerGrabService, CrawlerGrabService>();
            container.RegisterType<ICrawlerManageService, CrawlerManageService>();
            container.RegisterType<IFunctionService, FunctionService>();
            container.RegisterType<ILikesService, LikesService>();
            container.RegisterType<ILogService, LogService>();
            container.RegisterType<INewsTypeService, NewsTypeService>();
            container.RegisterType<IPermissionRoleService, PermissionRoleService>();
            container.RegisterType<IPictureService, PictureService>();
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<IUsersService, UsersService>();
            container.RegisterType<IPowerService, PowerService>();
            container.RegisterType<IRoleService, RoleService>();
            container.RegisterType<IManagerService, ManagerService>();
            //container.RegisterType<CollectService, ICollectService>();

        }
    }
}