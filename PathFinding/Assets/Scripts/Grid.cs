﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//枚举格子类型
public enum GridType
{
    Normal,
    Start,
    End,
    Barrier
}

//实现格子类
public class Grid : IComparable
{
    //坐标
    public int x,y;
    
    //类型
    public GridType type;
    //格子的归属（父格子）
	public Grid parent;

    //Astar
    //属性
    public int f,g,h;
    //赋值
    public Grid(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    //排序
    public int CompareTo(object obj)
    {
        Grid grid = (Grid)obj;
        if(this.f < grid.f)
        {
            return -1;
        }
        
        if(this.f > grid.f)
        {
            return 1;
        }
        return 0;
    }
    //

    //Dijkstra
    //
    
    //Floyd
    //

}