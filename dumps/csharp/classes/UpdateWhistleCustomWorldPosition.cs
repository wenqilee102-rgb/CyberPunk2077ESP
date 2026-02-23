using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateWhistleCustomWorldPosition : UpdateWhistlePosition
	{
		private CHandle<AIArgumentMapping> _outPositionArgument;

		[Ordinal(0)] 
		[RED("outPositionArgument")] 
		public CHandle<AIArgumentMapping> OutPositionArgument
		{
			get => GetProperty(ref _outPositionArgument);
			set => SetProperty(ref _outPositionArgument, value);
		}

		public UpdateWhistleCustomWorldPosition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
