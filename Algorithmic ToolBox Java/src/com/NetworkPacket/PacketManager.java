package com.NetworkPacket;

import java.util.ArrayDeque;
import java.util.Queue;
import java.util.Scanner;

public class PacketManager {
    public static void main(String[] args)
    {
        Scanner scanner = new Scanner(System.in);
        int bufferSize = scanner.nextInt();
        int n = scanner.nextInt();
        ArrayDeque<Packet> packets = new ArrayDeque<Packet>();
        for (int i = 0; i < n; i++)
        {
            packets.push(new Packet(scanner.nextInt(), scanner.nextInt()));
        }
        while(packets.size() > 0)
        {
            Packet currentPacket = packets.pop();
            
        }
    }
}

class Packet
{
    int ArrivalTime;
    int ProcTime;

    public Packet(int ArrivalTime, int ProcTime)
    {
        this.ArrivalTime = ArrivalTime;
        this.ProcTime = ProcTime;
    }
}
