using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerkPoinsActionRequest : gamePlayerScriptableSystemRequest
	{
		private CInt32 _pointDiff;

		[Ordinal(1)] 
		[RED("pointDiff")] 
		public CInt32 PointDiff
		{
			get => GetProperty(ref _pointDiff);
			set => SetProperty(ref _pointDiff, value);
		}

		public NewPerkPoinsActionRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
