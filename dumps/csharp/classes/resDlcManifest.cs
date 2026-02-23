using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class resDlcManifest : CResource
	{
		private raRef<CResource> _tweakBlob;
		private raRef<CResource> _quest;
		private raRef<CResource> _journal;
		private raRef<CResource> _factories;
		private raRef<CResource> _weaponAppearances;
		private raRef<CResource> _vehicleAppearances;
		private raRef<CResource> _communitySpawnsets;
		private raRef<CResource> _archetypeSet;
		private raRef<CResource> _vehicleCovers;
		private raRef<CResource> _cookedAudioMetadata;
		private raRef<CResource> _voiceTags;
		private raRef<CResource> _widgetsLibrariesOverrides;
		private raRef<CResource> _gameDefsList;
		private raRef<CResource> _cookedMultilayerSetup;
		private raRef<CResource> _visualTagsToAppearanceNames;
		private raRef<CResource> _appearanceNameToVisualTags;
		private raRef<CResource> _defaultAppearances;
		private raRef<CResource> _colorVariantsMap;

		[Ordinal(1)] 
		[RED("tweakBlob")] 
		public raRef<CResource> TweakBlob
		{
			get => GetProperty(ref _tweakBlob);
			set => SetProperty(ref _tweakBlob, value);
		}

		[Ordinal(2)] 
		[RED("quest")] 
		public raRef<CResource> Quest
		{
			get => GetProperty(ref _quest);
			set => SetProperty(ref _quest, value);
		}

		[Ordinal(3)] 
		[RED("journal")] 
		public raRef<CResource> Journal
		{
			get => GetProperty(ref _journal);
			set => SetProperty(ref _journal, value);
		}

		[Ordinal(4)] 
		[RED("factories")] 
		public raRef<CResource> Factories
		{
			get => GetProperty(ref _factories);
			set => SetProperty(ref _factories, value);
		}

		[Ordinal(5)] 
		[RED("weaponAppearances")] 
		public raRef<CResource> WeaponAppearances
		{
			get => GetProperty(ref _weaponAppearances);
			set => SetProperty(ref _weaponAppearances, value);
		}

		[Ordinal(6)] 
		[RED("vehicleAppearances")] 
		public raRef<CResource> VehicleAppearances
		{
			get => GetProperty(ref _vehicleAppearances);
			set => SetProperty(ref _vehicleAppearances, value);
		}

		[Ordinal(7)] 
		[RED("communitySpawnsets")] 
		public raRef<CResource> CommunitySpawnsets
		{
			get => GetProperty(ref _communitySpawnsets);
			set => SetProperty(ref _communitySpawnsets, value);
		}

		[Ordinal(8)] 
		[RED("archetypeSet")] 
		public raRef<CResource> ArchetypeSet
		{
			get => GetProperty(ref _archetypeSet);
			set => SetProperty(ref _archetypeSet, value);
		}

		[Ordinal(9)] 
		[RED("vehicleCovers")] 
		public raRef<CResource> VehicleCovers
		{
			get => GetProperty(ref _vehicleCovers);
			set => SetProperty(ref _vehicleCovers, value);
		}

		[Ordinal(10)] 
		[RED("cookedAudioMetadata")] 
		public raRef<CResource> CookedAudioMetadata
		{
			get => GetProperty(ref _cookedAudioMetadata);
			set => SetProperty(ref _cookedAudioMetadata, value);
		}

		[Ordinal(11)] 
		[RED("voiceTags")] 
		public raRef<CResource> VoiceTags
		{
			get => GetProperty(ref _voiceTags);
			set => SetProperty(ref _voiceTags, value);
		}

		[Ordinal(12)] 
		[RED("widgetsLibrariesOverrides")] 
		public raRef<CResource> WidgetsLibrariesOverrides
		{
			get => GetProperty(ref _widgetsLibrariesOverrides);
			set => SetProperty(ref _widgetsLibrariesOverrides, value);
		}

		[Ordinal(13)] 
		[RED("gameDefsList")] 
		public raRef<CResource> GameDefsList
		{
			get => GetProperty(ref _gameDefsList);
			set => SetProperty(ref _gameDefsList, value);
		}

		[Ordinal(14)] 
		[RED("cookedMultilayerSetup")] 
		public raRef<CResource> CookedMultilayerSetup
		{
			get => GetProperty(ref _cookedMultilayerSetup);
			set => SetProperty(ref _cookedMultilayerSetup, value);
		}

		[Ordinal(15)] 
		[RED("visualTagsToAppearanceNames")] 
		public raRef<CResource> VisualTagsToAppearanceNames
		{
			get => GetProperty(ref _visualTagsToAppearanceNames);
			set => SetProperty(ref _visualTagsToAppearanceNames, value);
		}

		[Ordinal(16)] 
		[RED("appearanceNameToVisualTags")] 
		public raRef<CResource> AppearanceNameToVisualTags
		{
			get => GetProperty(ref _appearanceNameToVisualTags);
			set => SetProperty(ref _appearanceNameToVisualTags, value);
		}

		[Ordinal(17)] 
		[RED("defaultAppearances")] 
		public raRef<CResource> DefaultAppearances
		{
			get => GetProperty(ref _defaultAppearances);
			set => SetProperty(ref _defaultAppearances, value);
		}

		[Ordinal(18)] 
		[RED("colorVariantsMap")] 
		public raRef<CResource> ColorVariantsMap
		{
			get => GetProperty(ref _colorVariantsMap);
			set => SetProperty(ref _colorVariantsMap, value);
		}

		public resDlcManifest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
