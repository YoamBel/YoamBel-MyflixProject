import { StyleSheet, Text, View,SafeAreaView,ActivityIndicator } from 'react-native';
import React, { useState,useEffect } from 'react';
import Home from '../Components/Home';
import News from '../Components/News';
import Download from '../Components/Download';
import SearchBar from '../Components/SearchBar';
import { MaterialIcons } from '@expo/vector-icons';
import { createMaterialBottomTabNavigator } from '@react-navigation/material-bottom-tabs';
import { AntDesign } from '@expo/vector-icons';


const Tab = createMaterialBottomTabNavigator();


const TabNavBot = () =>{

    return (
        <Tab.Navigator style = {styles.Tab}
          initialRouteName="Home"
          activeColor="white"
          barStyle={{ backgroundColor: '#181818' }}>
            <Tab.Screen 
              name="home"
              component={Home}
              options={{
                tabBarLabel: 'Home',
                tabBarIcon: () => (
                  <MaterialIcons name="movie-creation" size={24} color="#C2C2C2" />
                ),
              }}/>
            <Tab.Screen
              name="news"
              component={News}
              options={{
                tabBarLabel: 'News',
                tabBarIcon: () => (
                  <MaterialIcons name="local-movies" size={24} color="#C2C2C2" />
                ),
              }}/>
            <Tab.Screen
              name="download"
              component={Download}
              options={{
                tabBarLabel: 'Download',
                tabBarIcon: () => (
                  <MaterialIcons name="movie-filter" size={24} color="#C2C2C2" />
                ),
              }}/>
               <Tab.Screen
              name="searchBar"
              component={SearchBar}
              options={{
                tabBarLabel: 'Search',
                tabBarIcon: () => (
                  <AntDesign name="search1" size={24} color="#C2C2C2" />  
                ),
              }}/>
        </Tab.Navigator>
    );
  }
  
  const styles = StyleSheet.create({
    container: {},
  });
  
  export default  TabNavBot;