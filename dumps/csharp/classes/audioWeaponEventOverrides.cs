using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponEventOverrides : audioInlinedAudioMetadata
	{
		private CArray<audioWeaponEventOverride> _entries;
		private CHandle<audioWeaponEventOverride> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioWeaponEventOverride> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioWeaponEventOverride> EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}

		public audioWeaponEventOverrides(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
