using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldWidgetComponent : IWorldWidgetComponent
	{
		private rRef<inkWidgetLibraryResource> _cursorResource;
		private raRef<inkWidgetLibraryResource> _widgetResource;
		private CName _itemNameToSpawn;
		private raRef<CBitmapTexture> _staticTextureResource;
		private worlduiSceneWidgetProperties _sceneWidgetProperties;
		private CFloat _spawnDistanceOverride;
		private CBool _limitedSpawnDistanceFromVehicle;
		private SUIScreenDefinition _screenDefinition;

		[Ordinal(12)] 
		[RED("cursorResource")] 
		public rRef<inkWidgetLibraryResource> CursorResource
		{
			get => GetProperty(ref _cursorResource);
			set => SetProperty(ref _cursorResource, value);
		}

		[Ordinal(13)] 
		[RED("widgetResource")] 
		public raRef<inkWidgetLibraryResource> WidgetResource
		{
			get => GetProperty(ref _widgetResource);
			set => SetProperty(ref _widgetResource, value);
		}

		[Ordinal(14)] 
		[RED("itemNameToSpawn")] 
		public CName ItemNameToSpawn
		{
			get => GetProperty(ref _itemNameToSpawn);
			set => SetProperty(ref _itemNameToSpawn, value);
		}

		[Ordinal(15)] 
		[RED("staticTextureResource")] 
		public raRef<CBitmapTexture> StaticTextureResource
		{
			get => GetProperty(ref _staticTextureResource);
			set => SetProperty(ref _staticTextureResource, value);
		}

		[Ordinal(16)] 
		[RED("sceneWidgetProperties")] 
		public worlduiSceneWidgetProperties SceneWidgetProperties
		{
			get => GetProperty(ref _sceneWidgetProperties);
			set => SetProperty(ref _sceneWidgetProperties, value);
		}

		[Ordinal(17)] 
		[RED("spawnDistanceOverride")] 
		public CFloat SpawnDistanceOverride
		{
			get => GetProperty(ref _spawnDistanceOverride);
			set => SetProperty(ref _spawnDistanceOverride, value);
		}

		[Ordinal(18)] 
		[RED("limitedSpawnDistanceFromVehicle")] 
		public CBool LimitedSpawnDistanceFromVehicle
		{
			get => GetProperty(ref _limitedSpawnDistanceFromVehicle);
			set => SetProperty(ref _limitedSpawnDistanceFromVehicle, value);
		}

		[Ordinal(19)] 
		[RED("screenDefinition")] 
		public SUIScreenDefinition ScreenDefinition
		{
			get => GetProperty(ref _screenDefinition);
			set => SetProperty(ref _screenDefinition, value);
		}

		public WorldWidgetComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
