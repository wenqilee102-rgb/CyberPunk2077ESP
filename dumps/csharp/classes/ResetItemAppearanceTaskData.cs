using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ResetItemAppearanceTaskData : gameScriptTaskData
	{
		private CHandle<gameTransactionSystem> _ts;
		private CEnum<gamedataEquipmentArea> _area;
		private CBool _force;

		[Ordinal(0)] 
		[RED("ts")] 
		public CHandle<gameTransactionSystem> Ts
		{
			get => GetProperty(ref _ts);
			set => SetProperty(ref _ts, value);
		}

		[Ordinal(1)] 
		[RED("area")] 
		public CEnum<gamedataEquipmentArea> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(2)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetProperty(ref _force);
			set => SetProperty(ref _force, value);
		}

		public ResetItemAppearanceTaskData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
