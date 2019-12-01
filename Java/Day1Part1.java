/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package aoc2019day1;

import java.io.IOException;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

/**
 *
 * @author inquis1t0r
 */
public class AoC2019Day1 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException {
        // TODO code application logic here
        String fileName = "C:\\Users\\inquis1t0r\\Documents\\NetBeansProjects\\AoC2019Day1\\src\\aoc2019day1\\input.txt";
        
        List<Integer> ints = Files.lines(Paths.get(fileName))
                          .map(Integer::parseInt)
                          .collect(Collectors.toList());
        
        int result = 0;
        
        for(int x : ints){
        //System.out.println(x);
        result += x / 3 - 2;
        }
        System.out.println(result);
    }
    
}
