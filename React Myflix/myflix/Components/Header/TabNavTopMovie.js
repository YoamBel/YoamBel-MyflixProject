import { StyleSheet, TextInput, View,SafeAreaView,ActivityIndicator } from 'react-native';
import React, { useState,useEffect } from 'react';
import Movie from '../Movie';
import Serie from '../Serie';
import Anime from '../Anime';
import { MaterialIcons } from '@expo/vector-icons';
import { createMaterialTopTabNavigator } from '@react-navigation/material-top-tabs'


const Tab = createMaterialTopTabNavigator();



const TabNavTopMovie = () =>{

    return (
        <Tab.Navigator style = {styles.container}
          initialRouteName="Movie"
          backBehavior = "history"         
          tabBarOptions = { {
            labelStyle : { fontSize : 11 , color : 'white' } ,   
            tabStyle : { largeur : 100 } , 
            scrollEnabled: false, 
            style : { backgroundColor : 'transparent'} ,   
          }}>
            <Tab.Screen 
              name="movie"
              component={Movie}
              options={{
                tabBarLabel: 'Movie',
              }}/>
            <Tab.Screen
              name="serie"
              component={Serie}
              options={{
                tabBarLabel: 'Series',
              }}/>
            <Tab.Screen
              name="anime"
              component={Anime}
              options={{
                tabBarLabel: 'Anime',
              }}/>
        </Tab.Navigator>
    );
  }
  
  const styles = StyleSheet.create({
    container: {
      backgroundColor:'#333',
    },
  });
  
  export default  TabNavTopMovie;