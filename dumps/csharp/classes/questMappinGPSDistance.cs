using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMappinGPSDistance : questIDistance
	{
		private CHandle<gameJournalPath> _mappinPath;

		[Ordinal(0)] 
		[RED("mappinPath")] 
		public CHandle<gameJournalPath> MappinPath
		{
			get => GetProperty(ref _mappinPath);
			set => SetProperty(ref _mappinPath, value);
		}

		public questMappinGPSDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
