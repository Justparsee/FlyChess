# FlyChess
小游戏
	工具(结构体)：Vector2{x,y}

	地图(棋盘)
		地图单元格的数组
			地图单元格
				位置：
				图标：▲∞★‖■
				类型：地雷，跳跃，抽奖，暂停，方块
		行为：
             初始化地图，给每个位置赋予一个属性
	棋子
		id：玩家标识
		位置
		图标：◎
		状态:是否暂停
		行为：
			移动（通过外部接受数值移动）
			触发事件(检测移动后该方格的类型，并返回对应事件)
			交换位置(与另一个玩家交换位置)
			暂停(让暂停on，过了一回合就关闭)