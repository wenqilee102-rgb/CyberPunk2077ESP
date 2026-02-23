using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEP1RequestFilter : gameCustomRequestFilter
	{
		private CBool _isEP1;

		[Ordinal(0)] 
		[RED("isEP1")] 
		public CBool IsEP1
		{
			get => GetProperty(ref _isEP1);
			set => SetProperty(ref _isEP1, value);
		}

		public gameEP1RequestFilter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
