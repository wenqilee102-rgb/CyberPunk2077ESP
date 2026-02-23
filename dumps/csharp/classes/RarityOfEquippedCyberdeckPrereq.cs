using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RarityOfEquippedCyberdeckPrereq : gameIScriptablePrereq
	{
		private CInt32 _minimumQuality;

		[Ordinal(0)] 
		[RED("minimumQuality")] 
		public CInt32 MinimumQuality
		{
			get => GetProperty(ref _minimumQuality);
			set => SetProperty(ref _minimumQuality, value);
		}

		public RarityOfEquippedCyberdeckPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
