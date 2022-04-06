import { StyleSheet, Text, View,SafeAreaView,ActivityIndicator } from 'react-native';
import React, { useState,useEffect } from 'react';
import { StatusBar } from 'expo-status-bar';
import { NavigationContainer } from '@react-navigation/native';
import StackNav from './Navigation/StackNav'
import News from './Components/News';
//import store from './Components/Redux/store';
//import { Provider } from 'react-redux';

//<Provider store = {store}></Provider>

const App = () =>{

   

  return (  
    
        <SafeAreaView style={styles.container}>
        <NavigationContainer>
          <StackNav/>      
        </NavigationContainer>
        <StatusBar style="auto" />
      </SafeAreaView>  
    
        
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    paddingTop: Platform.OS ==='android' ? 25 : 0,
    //backgroundColor: 'black',
    
  },
});

export default  App;