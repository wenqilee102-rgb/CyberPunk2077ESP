using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GalleryFavoriteManager : inkWidgetLogicController
	{
		private CName _favoritesSettingGroup;
		private CName _favoritesSettingVar;
		private wCHandle<inkISystemRequestsHandler> _systemHandler;
		private CArray<CUInt32> _favoritesValue;

		[Ordinal(1)] 
		[RED("favoritesSettingGroup")] 
		public CName FavoritesSettingGroup
		{
			get => GetProperty(ref _favoritesSettingGroup);
			set => SetProperty(ref _favoritesSettingGroup, value);
		}

		[Ordinal(2)] 
		[RED("favoritesSettingVar")] 
		public CName FavoritesSettingVar
		{
			get => GetProperty(ref _favoritesSettingVar);
			set => SetProperty(ref _favoritesSettingVar, value);
		}

		[Ordinal(3)] 
		[RED("systemHandler")] 
		public wCHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetProperty(ref _systemHandler);
			set => SetProperty(ref _systemHandler, value);
		}

		[Ordinal(4)] 
		[RED("favoritesValue")] 
		public CArray<CUInt32> FavoritesValue
		{
			get => GetProperty(ref _favoritesValue);
			set => SetProperty(ref _favoritesValue, value);
		}

		public GalleryFavoriteManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
