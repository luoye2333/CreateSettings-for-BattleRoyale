Public Class Form1
	Private Sub SaveFile()
		Dim sw As IO.StreamWriter = New IO.StreamWriter("default.yml")
		sw.Write("player-status-option:
  maxHealth: {0}    # 玩家的默认最大血量
player-spawn-option:
  range:
    min: {1}    # 散布的最大范围(正方形半边长)
    max: {2}    # 散布的最大范围(正方形半边长)
  radius: {3}    # 散布的目标距离(圆形半径)
  min-relative-space: {4}    # 散布点间的最小距离(直线距离)
  calculating-times: {5}    # 散布时的尝试数(较低的尝试数易导致散布失败, 较高易导致服务器卡顿)
worldborder-option:
  damage:
    amount: {6}    # 世界边界伤害
    buffer-distance: {7}    # 世界边界伤害缓冲区
  warning-distance: {8}    # 世界边界预警距离
  radius:
    min: {9}    # 世界边界最小半径(圆形半径)
    max: {10}    # 世界边界初始半径(圆形半径)
  shrink-speed: {11}    # 世界边界收缩速度(圆形半径)
  shrink-accelerating-option:
    enabled: {12}
    activate-item: {13}    # 激活加速收缩的物品(需为严格Material名)
    speed: {14}    # 世界边界加速倍率
    duration: {15}    # 世界边界加速收缩有效时间
    cool-down: {16}    # 加速冷却时间(ticks)
    beginning-protect-time: {17}    # 初始保护时间(ticks)
game-misc-option:
  protect-animal: {18}    # 动物是否免疫一切伤害
  ore-auto-melt: {19}    # 挖掘矿石时, 是否直接掉落矿物锭
  hide-playername: {20}    # 事件发生时是否显示玩家名(对控制台记录无效)
  game-preparing-time: {21}    # 游戏加载的准备时间
  compass-option:
    enabled: {22}
    mode: {23}    # 使用指南针的方式(true: 右键交互; false: 丢出)
    cool-down: {24}    # 指南针冷却时间(ticks)
    summon-blaze: {25}
  deathmatch: {26}

# 若要自定义配置文件, 请复制上方全部内容, 改变一级列表名
# 如:
# custom-config: 
#   player-spread-option: 
# ......
# 然后在准备游戏时使用指令 
# /battleroyale preset [worldName] [configName]
# 如:
# /battleroyale preset overworld custom-config
# 以使用该配置”,
			 TextBox1.Text, TextBox2.Text, TextBox3.Text,
			 TextBox4.Text, TextBox5.Text, TextBox6.Text,
			 TextBox7.Text, TextBox8.Text, TextBox9.Text,
			TextBox10.Text, TextBox11.Text, TextBox12.Text,
			 ComboBox1.Text, TextBox13.Text, TextBox14.Text,
			 TextBox15.Text, TextBox16.Text, TextBox17.Text,
			 ComboBox2.Text, ComboBox3.Text, ComboBox4.Text,
			 TextBox18.Text, ComboBox5.Text, ComboBox6.Text,
			 TextBox19.Text, ComboBox7.Text, ComboBox8.Text)

		sw.Close()
	End Sub
	Private Sub DefaultData()
		TextBox1.Text = 40
		TextBox2.Text = 500
		TextBox3.Text = 1750
		TextBox4.Text = 1500
		TextBox5.Text = 500
		TextBox6.Text = 512
		TextBox7.Text = 1.0
		TextBox8.Text = 0
		TextBox9.Text = 8
		TextBox10.Text = 64
		TextBox11.Text = 2048
		TextBox12.Text = 1.0
		ComboBox1.Text = True
		TextBox13.Text = "IRON_BLOCK"
		TextBox14.Text = 1.0
		TextBox15.Text = 1200
		TextBox16.Text = 300
		TextBox17.Text = 6000
		ComboBox2.Text = True
		ComboBox3.Text = False
		ComboBox4.Text = True
		TextBox18.Text = 30
		ComboBox5.Text = True
		ComboBox6.Text = True
		TextBox19.Text = 100
		ComboBox7.Text = True
		ComboBox8.Text = True
	End Sub
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		DefaultData()
	End Sub
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		SaveFile()
	End Sub
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		DefaultData()
	End Sub
	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Close()
	End Sub
End Class
